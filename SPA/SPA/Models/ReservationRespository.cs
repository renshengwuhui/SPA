using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**********
 * 作者：人生无悔
 * 日期：2018-04-19
 * 内容：预订类数据仓库
 **********/

namespace SPATest1.Models
{
    /// <summary>
    /// 预订类数据仓库
    /// </summary>
    public class ReservationRespository
    {
        /// <summary>
        /// 数据仓库，模拟数据库，非实体数据库
        /// </summary>
        static ReservationRespository repo = new ReservationRespository();
        /// <summary>
        /// 数据清单
        /// </summary>
        List<Reservation> repoDatas = new List<Reservation>
        {
            new Reservation { ReservationId =1,ClientName="A",Location="Room1"},
            new Reservation { ReservationId =2,ClientName="B",Location="Room2"},
            new Reservation { ReservationId =3,ClientName="C",Location="Room3"},
        };
        /// <summary>
        /// 当前数据
        /// </summary>
        public static ReservationRespository Current
        {
            get { return repo; }
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Reservation> GetAll()
        {
            return repoDatas;
        }
        /// <summary>
        /// 根据Id获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Reservation Get(int id)
        {
            return repoDatas.Where(r => r.ReservationId == id).FirstOrDefault();
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Reservation Add(Reservation item)
        {
            item.ReservationId = repoDatas.Max(p => p.ReservationId) + 1;
            repoDatas.Add(item);
            return item;
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            Reservation item = Get(id);
            if (item != null)
            {
                repoDatas.Remove(item);
            }
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(Reservation item)
        {
            Reservation storedItem = Get(item.ReservationId);
            if (storedItem != null)
            {
                storedItem.ClientName = item.ClientName;
                storedItem.Location = item.Location;
                return true;
            }
            else { return false; }
        }
    }
}