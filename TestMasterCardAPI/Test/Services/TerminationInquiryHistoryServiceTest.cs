using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MasterCard.SDK;
using MasterCard.SDK.Services.Match;
using MasterCard.SDK.Services.Match.Domain;
using MasterCard.SDK.Services.Match.Domain.Options;

using Test.Services.Util;

namespace Test.Services
{
    [TestClass]
    public class TerminationInquiryHistoryServiceTest
    {
        TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        TerminationInquiryService service;
        TerminationInquiryHistoryService historyService;
        TerminationInquiryRequest request;

        [TestInitialize]
        public void Init()
        {
            this.service = new TerminationInquiryService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
            this.historyService = new TerminationInquiryHistoryService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
            this.request = new TerminationInquiryRequest();
            request.AcquirerId = "1996";
            request.TransactionReferenceNumber = "12345";
            request.Merchant.Name = "TERMINATED MERCHANT 2";
            request.Merchant.DoingBusinessAsName = "DOING BUSINESS AS TERMINATED MERCHANT 2";
            request.Merchant.PhoneNumber = "5555555555";
            request.Merchant.Address.Line1 = "20 EAST MAIN ST";
            request.Merchant.Address.Line2 = "EAST ISLIP           NY";
            request.Merchant.Address.City = "EAST ISLIP";
            request.Merchant.Address.CountrySubdivision = "NY";
            request.Merchant.Address.PostalCode = "55555";
            request.Merchant.Address.Country = "USA";
            request.Merchant.CountrySubdivisionTaxId = "205545287";
            request.Merchant.NationalTaxId = "2891327625";
            principal_Type principal = new principal_Type();
            principal.FirstName = "PATRICIA";
            principal.LastName = "CLARKE";
            principal.NationalId = "4236559970";
            principal.PhoneNumber = "5555555555";
            principal.Address.Line1 = "93-52 243 STREET";
            principal.Address.City = "BELLEROSE";
            principal.Address.CountrySubdivision = "NY";
            principal.Address.PostalCode = "55555-5555";
            principal.Address.Country = "USA";
            request.Merchant.Principal.Add(principal);
        }

        [TestMethod]
        public void TestService()
        {
            TerminationInquiry inquiry = service.GetTerminationInquiry(
                request,
                new TerminationInquiryRequestOptions(0, 10)
                );
            Assert.AreEqual(true, inquiry.TerminatedMerchant.Count > 0);
            Assert.AreEqual(true, inquiry.Ref != null && inquiry.Ref.Length > 0);
            Assert.AreEqual(true, inquiry.TransactionReferenceNumber != null && inquiry.TransactionReferenceNumber.Length > 0);
            Assert.AreEqual(true, inquiry.GetReferenceId().Length > 0);

            TerminationInquiryHistoryOptions historyOptions = new TerminationInquiryHistoryOptions(
                0,
                10,
                1996,
                long.Parse(inquiry.GetReferenceId())
                );
            TerminationInquiry terminationInquiry = historyService.GetTerminationInquiry(historyOptions);
            Assert.AreEqual(true, terminationInquiry.TerminatedMerchant != null);
        }
    }
}
