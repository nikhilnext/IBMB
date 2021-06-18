using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp
{
    public class DealQuery
    {




       /// public static string finalquery = "select distinct DealType,Discription,Prices,Sector,Title,Year from deals_data where DealType like case when 0 != {0} then '{1}' else '%%'end and Sector like case when 0 != {2} then '{3}' else '%%'end order by Year desc";

        //public static string finalquery = "select distinct DealType,Discription,Price,Sector,Title,Year from deals_data where DealType like case when 0 != {0} then '{1}' else '%%'end and Sector like case when 0 != {2} then '{3}' else '%%'end   and Year like case when 0 != {4} then '{5}' else '%%'end ";
      //  public static string dataqrypriEuity = "select distinct  Year,Title,Sector,Prices,Discription,DealType from deals_data  where DealType ='Private Equity' order by Year desc";
      //  public static string dataqryEquCap = " select distinct  Year,Title,Sector,Prices,Discription,DealType from deals_data  where DealType = 'Equity Capital Market & Equity Issuance' order by Year desc";
      //  public static string dataqryMerAcq = " select distinct  Year,Title,Sector,Prices,Discription,DealType from deals_data  where DealType = 'Mergers & Acquisitions' order by Year desc";
      //  public static string dataqryCapMarkAdv = " select distinct  Year,Title,Sector,Prices,Discription,DealType from deals_data  where DealType = 'Capital Market & Advisory' order by Year desc";
      //  public static string dataqryCapMark = " select distinct  Year,Title,Sector,Prices,Discription,DealType from deals_data  where DealType = 'Capital Market & Debt' order by Year desc";
      //  public static string dataqryPubOff = " select distinct  Year,Title,Sector,Prices,Discription,DealType from deals_data  where DealType = 'Public Offers' order by Year desc";
      //  public static string alldataFccb = "select distinct  Year,Title,Sector,Prices,Discription,DealType from deals_data  where DealType = 'FCCB & Bonds' order by Year desc";
      //  public static string alldataBuyBack = "select distinct  Year,Title,Sector,Prices,Discription,DealType from deals_data  where DealType = 'Buyback and Delisting' order by Year desc";
      //  public static string alldataGDR = "select distinct  Year,Title,Sector,Prices,Discription,DealType from deals_data  where DealType = 'GDR Issuance' order by Year desc";
      //  public static string alldataECM = "select distinct  Year,Title,Sector,Prices,Discription,DealType from deals_data  where DealType = 'ECM & Block Sale' order by Year desc";
     //   public static string alldataAcqFinc = "select distinct  Year,Title,Sector,Prices,Discription,DealType from deals_data  where DealType = 'Acquisition Financing' order by Year desc";




    }
}