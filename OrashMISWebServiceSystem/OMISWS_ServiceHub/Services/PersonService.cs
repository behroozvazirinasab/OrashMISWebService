using Dapper;
using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;
using OMISWS_ServiceHub.Contexts;
using OMISWS_ServiceHub.IServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_ServiceHub.Services
{
    public class PersonService : IPersonService
    {
        private readonly OMISWSDBContext dbContext;

        public PersonService(OMISWSDBContext _dbContext)
        {
            dbContext = _dbContext;
        }




        public List<ResponseModel2> runInsertPersonsp(PersonInsertViewModel personInsertViewModel)
        {
            var query = "InsertPerson";

            var queryparams = new
            {
                Code = personInsertViewModel.Code,
                Name = personInsertViewModel.Name,
                Tel = personInsertViewModel.Tel,
                Address = personInsertViewModel.Address,
                Persons = personInsertViewModel.Persons,
                Expence = personInsertViewModel.Expence,
                Bank = personInsertViewModel.Bank,
                Cash = personInsertViewModel.Cash,
                Tuner = personInsertViewModel.Tuner,
                KlCodeRef = personInsertViewModel.KlCodeRef,
                MnCodeRef = personInsertViewModel.MnCodeRef,
                PerType = personInsertViewModel.PerType,
                Mobile = personInsertViewModel.Mobile,
                Fax = personInsertViewModel.Fax,
                EconomicCode = personInsertViewModel.EconomicCode,
                NationalCode = personInsertViewModel.NationalCode,
                RegisterNo = personInsertViewModel.RegisterNo,
                PostCode = personInsertViewModel.PostCode,
                NationalNo = personInsertViewModel.NationalNo,
                Email = personInsertViewModel.Email,
                Description = personInsertViewModel.Description,
                GoodRequest = personInsertViewModel.GoodRequest,
                Address2 = personInsertViewModel.Addres2,
                Tel2 = personInsertViewModel.Tel2,
                Mobile2 = personInsertViewModel.Mobile2,
                Email2 = personInsertViewModel.Email2,
                KlCashCodeRef = personInsertViewModel.KlCashCodeRef,
                MnCashCodeRef = personInsertViewModel.MnCashCodeRef,
                KlBankCodeRef = personInsertViewModel.KlBankCodeRef,
                MnBankCodeRef = personInsertViewModel.MnBankCodeRef,
                KlPayCodeRef = personInsertViewModel.KlPayCodeRef,
                MnPayCodeRef = personInsertViewModel.MnPayCodeRef,
                Craft = personInsertViewModel.Craft,
                StateIdRef = personInsertViewModel.StateIdRef,
                CityIdRef = personInsertViewModel.CityIdRef,
                VisitorCodeRef = personInsertViewModel.VisitorCodeRef,
                ActualType = personInsertViewModel.ActualType,
                TransactionTaxType = personInsertViewModel.TransactionTaxType,
                RateDefualt = personInsertViewModel.RateDefualt,
                BranchName = personInsertViewModel.BranchName,
                AccountType = personInsertViewModel.AccountType,
                AccountOwner = personInsertViewModel.AccountOwner,
                ShebaNo = personInsertViewModel.ShebaNo,
                CardNo = personInsertViewModel.CardNo,
                BranchTel = personInsertViewModel.BranchTel,
                BranchFax = personInsertViewModel.BranchFax,
                AccountNo = personInsertViewModel.AccountNo,
                IsActive = personInsertViewModel.IsActive,
                FName = personInsertViewModel.FName,
                LName = personInsertViewModel.LName,
                CalcTax = personInsertViewModel.CalcTax

            };

            var _res = dbContext.Connection.Query<ResponseModel2>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }



        public List<PersonSearchResponseModel> runSearchPersonsp(PersonSearchViewModel personSearchViewModel)
        {
            var query = "SearchPerson";

            var queryparams = new
            {
                Code = personSearchViewModel.Code,
                Name = personSearchViewModel.Name,
                Tel = personSearchViewModel.Tel,
                Address = personSearchViewModel.Address,
                Persons = personSearchViewModel.Persons,
                Expence = personSearchViewModel.Expence,
                Bank = personSearchViewModel.Bank,
                Cash = personSearchViewModel.Cash,
                Tuner = personSearchViewModel.Tuner,
                PerType = personSearchViewModel.PerType,
                Mobile = personSearchViewModel.Mobile,
                Fax = personSearchViewModel.Fax,
                EconomicCode = personSearchViewModel.EconomicCode,
                NationalCode = personSearchViewModel.NationalCode,
                RegisterNo = personSearchViewModel.RegisterNo,
                PostCode = personSearchViewModel.PostCode,
                NationalNo = personSearchViewModel.NationalNo,
                Description = personSearchViewModel.Description,
                IsActive = personSearchViewModel.ISActive,
                FName = personSearchViewModel.FName,
                LName = personSearchViewModel.LName

            };

            var _res = dbContext.Connection.Query<PersonSearchResponseModel>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }
    }
}
