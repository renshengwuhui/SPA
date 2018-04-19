using SPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

/**********
 * 作者：人生无悔
 * 日期：2018-04-19
 * 内容：REST 测试控制器
 **********/

namespace SPA.Controllers
{
    /// <summary>
    /// SPA MVVM REST
    /// </summary>
    public class WebController : ApiController
    {
        ReservationRespository repo = ReservationRespository.Current;
        public IEnumerable<Reservation> GetAllReservations()
        {
            return repo.GetAll();
        }
        public Reservation GetReservation(int id)
        {
            return repo.Get(id);
        }
        //不需要标记HttpPost，根据网络请求方式自动选择名称相对应方法执行
        //public Reservation PostReservation(Reservation item)
        [HttpPost]
        public Reservation CreateReservation(Reservation item)
        {
            return repo.Add(item);
        }
        //不需要标记HttpPut，根据网络请求方式自动选择名称相对应方法执行
        //public bool PutReservation(Reservation item)
        [HttpPut]
        public bool UpdateReservation(Reservation item)
        {
            return repo.Update(item);
        }
        public void DeleteReservation(int id)
        {
            repo.Remove(id);
        }
    }
}
