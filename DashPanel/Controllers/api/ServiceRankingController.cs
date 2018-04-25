using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DashPanel.Models;

namespace DashPanel.Controllers.api
{
    public class ServiceRankingController : ApiController
    {
        [HttpPost]
        public object GetTop5ChurnServiceReport(GetInfo getInfo)
        {
            DataSet ds =
                new CDA().GetDataSet(
                    "exec Partner_Basket.dbo.sp_GetServiceRankData '" + getInfo.FromDate + "','" + getInfo.EndDate +
                    "'", "WAPDB");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return Ok(ds.Tables[0]);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public object GetTop5GrowthServiceReport(GetInfo getInfo)
        {
            DataSet ds =
                new CDA().GetDataSet(
                    "exec Partner_Basket.dbo.sp_GetServiceRankData_Growth '" + getInfo.FromDate + "','" + getInfo.EndDate +
                    "'", "WAPDB");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return Ok(ds.Tables[0]);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public object GetTop5AnsdReport(GetInfo getInfo)
        {
            DataSet ds =
                new CDA().GetDataSet(
                    "exec Partner_Basket.dbo.sp_GetServiceRankData_Ansd '" + getInfo.FromDate + "','" + getInfo.EndDate +
                    "'", "WAPDB");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return Ok(ds.Tables[0]);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public object GetTop5AcsdReport(GetInfo getInfo)
        {
            DataSet ds =
                new CDA().GetDataSet(
                    "exec Partner_Basket.dbo.sp_GetServiceRankData_Acsd '" + getInfo.FromDate + "','" + getInfo.EndDate +
                    "'", "WAPDB");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return Ok(ds.Tables[0]);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public object GetBuddyOperatorWiseClosingData(GetInfo getInfo)
        {
            DataSet ds =
                new CDA().GetDataSet(
                    "exec Partner_Basket.dbo.sp_getClosingBaseDate '" + "buddy" + "','" + getInfo.EndDate +
                    "'", "WAPDB");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return Ok(ds.Tables[0]);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public object GetClubzOperatorWiseClosingData(GetInfo getInfo)
        {
            DataSet ds =
                new CDA().GetDataSet(
                    "exec Partner_Basket.dbo.sp_getClosingBaseDate '" + "Clubz" + "','" + getInfo.EndDate +
                    "'", "WAPDB");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return Ok(ds.Tables[0]);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public object GetBuddyOperatorWiseClosingDataApp(GetInfo getInfo)
        {
            DataSet ds =
                new CDA().GetDataSet(
                    "exec Partner_Basket.dbo.sp_getClosingBaseDate '" + "buddyapp" + "','" + getInfo.EndDate +
                    "'", "WAPDB");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return Ok(ds.Tables[0]);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public object GetClubzOperatorWiseClosingDataApp(GetInfo getInfo)
        {
            DataSet ds =
                new CDA().GetDataSet(
                    "exec Partner_Basket.dbo.sp_getClosingBaseDate '" + "clubzapp" + "','" + getInfo.EndDate +
                    "'", "WAPDB");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return Ok(ds.Tables[0]);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public object GetShaboxOperatorWiseClosingDataApp(GetInfo getInfo)
        {
            DataSet ds =
                new CDA().GetDataSet(
                    "exec Partner_Basket.dbo.sp_getClosingBaseDate '" + "shabox" + "','" + getInfo.EndDate + "','" + getInfo.FromDate +
                    "'", "WAPDB");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return Ok(ds.Tables[0]);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public object GetGameClubAndDigitalOperatorWiseClosing(GetInfo getInfo)
        {
            DataSet ds =
                new CDA().GetDataSet(
                    "exec Partner_Basket.dbo.sp_getClosingBaseDate '" + "gc" + "','" + getInfo.EndDate +
                    "'", "WAPDB");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return Ok(ds.Tables[0]);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public object GetLineChartData(GetInfo getInfo)
        {
            DataSet ds =
                new CDA().GetDataSet(
                    "exec Partner_Basket.dbo.sp_GetServiceRankData_Growth_Calculations '" + getInfo.FromDate + "','" + getInfo.EndDate +
                    "'", "WAPDB");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                return Ok(ds.Tables[0]);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public object TextGrowthServices(GetInfo getInfo)
        {
            DataSet ds = new CDA().GetDataSet("EXEC spGetBLinkShaboxSubBaseData '" + getInfo.FromDate + "','" + getInfo.EndDate + "'", "BLINK");
            DataSet growthService = new CDA().GetDataSet("exec Partner_Basket.dbo.sp_GetShaboxServicesGrowthChurnData", "WAPDB");
            if (growthService != null && growthService.Tables[0].Rows.Count > 0)
            {
                return Ok(growthService.Tables[0]);
            }
            else
            {
                return BadRequest();
            }

        }
        [HttpPost]
        public object TextChurnServices(GetInfo getInfo)
        {

            DataSet churnService = new CDA().GetDataSet("exec Partner_Basket.dbo.sp_GetShaboxServicesGrowthChurnData", "WAPDB");
            if (churnService != null && churnService.Tables[0].Rows.Count > 0)
            {
                return Ok(churnService.Tables[1]);
            }
            else
            {
                return BadRequest();
            }

        }
        [HttpPost]
        public object RawInfo(RawInfo rawInfo)
        {

            DataSet churnService = new CDA().GetDataSet
            (
                "exec Partner_Basket.dbo.sp_GetRawInfo '" + rawInfo.ServiceName + "','" + rawInfo.Operator + "'",
                "WAPDB"

                );
            if (churnService != null && churnService.Tables[0].Rows.Count > 0)
            {
                return Ok(churnService.Tables[0]);
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
