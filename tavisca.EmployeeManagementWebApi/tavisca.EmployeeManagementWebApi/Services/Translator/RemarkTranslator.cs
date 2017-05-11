using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tavisca.EmployeeManagementWebApi.Services.Translator
{
    public static class RemarkTranslator
    {
        public static BusinessLayer.Model.Remark ToDomainModel(this DataContract.Remark remark)
        {
            if (remark == null) return null;
            return new BusinessLayer.Model.Remark()
            {
                Text = remark.Text
            };
        }

        public static DataContract.Remark ToDataContract(this BusinessLayer.Model.Remark remark)
        {
            if (remark == null) return null;
            return new DataContract.Remark()
            {
                Text = remark.Text,
                CreateTimeStamp = remark.CreateTimeStamp
            };
        }

        public static DataContract.PagedList<DataContract.Remark> ToDataContract(this BusinessLayer.Model.PagedList<BusinessLayer.Model.Remark> remarkList)
        {
            if (remarkList == null) return null;
            var pagedList = new DataContract.PagedList<DataContract.Remark>();
            pagedList.PageNumber = remarkList.PageNumber;
            pagedList.PageSize = remarkList.PageSize;
            pagedList.TotalRecords = remarkList.TotalRecords;
            pagedList.Results = new List<DataContract.Remark>();
            remarkList.ForEach(remark =>
            {
                pagedList.Results.Add(new DataContract.Remark()
                {
                    Text = remark.Text,
                    CreateTimeStamp = remark.CreateTimeStamp
                });
            });
            return pagedList;
        }
    }
}