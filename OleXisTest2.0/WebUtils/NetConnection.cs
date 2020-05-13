using NAudio.CoreAudioApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OleXisTest
{
    public class NetConnection
    {
        public string Address { get; }
        public User User
        {
            get
            {
                return _User;
            }
        }
        public bool IsConnected
        {
            get
            {
                return _IsConnected;
            }
        }
        TokenUpdator updator;
        private User _User = null;
        private bool _IsConnected = false;
        public NetConnection(string IP, string Port)
        {
            updator = new TokenUpdator(this);
            Address = "http://" + IP + ":" + Port;
        }
        public void Login(LoginData loginData, Action<string, AccountInfo> onLogin)
        {
            Connect((error) =>
            {
                if (error == null)
                {
                    try
                    {
                        var netSender = new NetDataSender(
                            new RequestInfo("Login", SequrityUtils.Encrypt(loginData.ToJson(), _User.SecretKey), _User.UserToken),
                            (responseData) =>
                            {
                                var responseInfo = ResponseInfo.FromJson(responseData);
                                if(responseInfo.Error != null)
                                    onLogin(responseInfo.Error, null);
                                else
                                {
                                    var loginInfo = AccountInfo.FromJson(SequrityUtils.DecryptString(responseInfo.Data, _User.SecretKey));
                                    updator.Start();
                                    onLogin(null, loginInfo);
                                }
                            },
                            Address);
                    }
                    catch (Exception e)
                    {
                        onLogin("Ошибка авторизации: " + e.Message, null);
                    }
                }
                else
                {
                    onLogin(error, null);
                }
            });
        }
        public void Register(RegisterData registerData, Action<string> onRegister)
        {
            Connect((error) =>
            {
                if (error == null)
                {
                    try
                    {
                        var netSender = new NetDataSender(
                            new RequestInfo("RegisterStudent", SequrityUtils.Encrypt(registerData.ToJson(), _User.SecretKey), _User.UserToken),
                            (responseData) =>
                            {
                                var responseInfo = ResponseInfo.FromJson(responseData);
                                if (responseInfo.Error != null)
                                {
                                    Disconnect();
                                    onRegister(responseInfo.Error);
                                }
                                else
                                {
                                    if (SequrityUtils.DecryptString(responseInfo.Data, _User.SecretKey) == "OK")
                                    {
                                        Disconnect();
                                        onRegister(null);
                                    }
                                    else
                                    {
                                        Disconnect();
                                        onRegister(responseInfo.Error);
                                    }
                                }
                            },
                            Address);
                    }
                    catch (Exception e)
                    {
                        onRegister("Ошибка авторизации: " + e.Message);
                    }
                }
                else
                {
                    onRegister(error);
                }
            });
        }
        public void SendCommand(RequestInfo request, Action<string> onRecive)
        {
            if (!_IsConnected)
                throw new Exception("Необходимо подключится к серверу");
            var sender = new NetDataSender(request, onRecive, Address);
        }
        private void Connect(Action<string> onConnected)
        {
            try
            {
                var netSender = new NetDataSender(
                    new RequestInfo("OpenConnection", null, null),
                    (responseData) =>
                    {
                        var responseInfo = ResponseInfo.FromJson(responseData);
                        var data = Encoding.UTF8.GetString(responseInfo.Data);
                        _User = new User(data.Substring(0, data.IndexOf(' ')));
                        string publicKey;
                        _User.SecretKey = SequrityUtils.DiffieHellmanGetSecretKey(data.Substring(data.IndexOf(' ') + 1), out publicKey);
                        var netSender2 = new NetDataSender(
                            new RequestInfo("SetDF", Encoding.UTF8.GetBytes(publicKey), _User.UserToken),
                            (string responseData2) =>
                            {
                                responseInfo = ResponseInfo.FromJson(responseData2);
                                if (SequrityUtils.DecryptString(responseInfo.Data, _User.SecretKey) == "CONNECTION_STARTED")
                                {
                                    _IsConnected = true;
                                    onConnected(null);
                                }
                                else
                                    onConnected("Неизвестная ошибка подключения");
                            },
                            Address);
                    },
                    Address);
            }
            catch(Exception e)
            {
                onConnected("Ошибка подключения: " + e.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                updator.Stop();
                var netSender = new NetDataSender(new RequestInfo("Disconnect", null, _User.UserToken), (x)=> { }, Address);
            }
            catch
            {

            }
            finally
            {
                _IsConnected = false;
                _User = null;
            }
        }

        ~NetConnection()
        {
            if (_IsConnected)
                Disconnect();
        }
    }
}
