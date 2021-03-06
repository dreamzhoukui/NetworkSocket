﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSocket
{
    /// <summary>
    /// 表示ITag的数据项
    /// </summary>
    public struct TagItem
    {
        /// <summary>
        /// 值
        /// </summary>
        private object value;

        /// <summary>
        /// 是否为NULL
        /// </summary>
        public bool IsNull
        {
            get
            {
                return this.value == null;
            }
        }

        /// <summary>
        /// ITag的数据项
        /// </summary>
        /// <param name="value">数据</param>
        public TagItem(object value)
        {
            this.value = value;
        }

        /// <summary>
        /// 强制转换为指定类型
        /// </summary>
        /// <typeparam name="T">指定类型</typeparam>
        /// <returns></returns>
        public T As<T>()
        {
            return this.IsNull ? default(T) : (T)this.value;
        }

        /// <summary>
        /// 强制转换为指定类型
        /// </summary>
        /// <typeparam name="T">指定类型</typeparam>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public T As<T>(T defaultValue)
        {
            return this.IsNull ? defaultValue : (T)this.value;
        }

        /// <summary>
        /// 转换为string
        /// </summary>
        /// <returns></returns>
        public string AsString()
        {
            return this.As<string>();
        }

        /// <summary>
        /// 转换为int
        /// </summary>
        /// <returns></returns>
        public int AsInt32()
        {
            return this.As<Int32>();
        }

        /// <summary>
        /// 转换为bool
        /// </summary>
        /// <returns></returns>
        public bool AsBoolean()
        {
            return this.As<Boolean>();
        }

        /// <summary>
        /// 转换为时间
        /// </summary>
        /// <returns></returns>
        public DateTime AsDateTime()
        {
            return this.As<DateTime>();
        }

        /// <summary>
        /// 转换为字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.IsNull ? null : this.value.ToString();
        }
    }
}
