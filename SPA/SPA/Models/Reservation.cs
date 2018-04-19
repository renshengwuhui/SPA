using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**********
 * 作者：人生无悔
 * 日期：2018-04-19
 * 内容：预订类
 **********/

namespace SPATest1.Models
{
    /// <summary>
    /// 预订类
    /// </summary>
    public class Reservation
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int ReservationId { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string ClientName { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        public string Location { get; set; }
    }
}