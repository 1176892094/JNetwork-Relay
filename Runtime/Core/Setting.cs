﻿using System;

namespace JFramework.Net
{
    [Serializable]
    public class Setting
    {
        /// <summary>
        /// 程序集
        /// </summary>
        public string Assembly = "Transport.dll";

        /// <summary>
        /// 使用传输
        /// </summary>
        public string Transport = "JFramework.Net.KcpTransport";

        /// <summary>
        /// 服务器密钥
        /// </summary>
        public string ServerKey = "Secret Key";

        /// <summary>
        /// 主线程循环时间
        /// </summary>
        public int UpdateTime = 10;

        /// <summary>
        /// 是否启用Rest服务
        /// </summary>
        public bool UseEndPoint = true;
        
        /// <summary>
        /// 是否请求服务器列表
        /// </summary>
        public bool RequestRoom = true;

        /// <summary>
        /// Rest服务器端口
        /// </summary>
        public ushort RestPort = 8080;
    }
}