using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

using MasterCard.SDK;

namespace Test.Services.Util 
{
    class TestUtils
    {
        private Environments.Environment environment = Environments.Environment.SANDBOX;

        private readonly string PASSWORD = @"changeit";
        private readonly string PRODUCTION_PK_DIR = @"configure-me";
        private readonly string PRODUCTION_CONSUMER_KEY = "configure-me";
        private readonly string SANDBOX_PK_DIR = @"C:\Users\JBK0718\dev\mastercard\keystore\masterpass\SandboxMCOpenAPI.p12";
        private readonly string SANDBOX_CONSUMER_KEY = "cLb0tKkEJhGTITp_6ltDIibO5Wgbx4rIldeXM_jRd4b0476c!414f4859446c4a366c726a327474695545332b353049303d";

        public TestUtils(Environments.Environment environment)
        {
            this.environment = environment;
        }

        public AsymmetricAlgorithm GetPrivateKey()
        {
            if (this.environment == Environments.Environment.PRODUCTION)
            {
                return GetPrivateKey(PRODUCTION_PK_DIR, PASSWORD);
            }
            else
            {
                return GetPrivateKey(SANDBOX_PK_DIR, PASSWORD);
            }
        }

        public string GetConsumerKey()
        {
            if (this.environment == Environments.Environment.PRODUCTION)
            {
                return PRODUCTION_CONSUMER_KEY;
            }
            else
            {
                return SANDBOX_CONSUMER_KEY;
            }
        }

        private AsymmetricAlgorithm GetPrivateKey(string keystorePath, string keystorePassword)
        {
            // Load the certificate from the keystore.
            X509Certificate2 mcIssuedCertificate =
                new X509Certificate2(keystorePath, keystorePassword);
            return mcIssuedCertificate.PrivateKey;
        }
    }
}
