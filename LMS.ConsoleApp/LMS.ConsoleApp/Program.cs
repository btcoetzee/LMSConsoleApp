namespace LMS.ConsoleApp
{
    using LeadEntity.Interface;
    using System;
    using System.Collections.Generic;

    class Program
    {
        public int QuotedProduct = 101;
        public string AdditonalProducts = "None";
        public string PriorBI = "100/300";
        public bool PriorInsurance = true;
        public int VehicleCount = 2;
        public string QuotedBI = "100/300";
        public int[] DisplayedBrands = new int[] { 22, 58, 181, 218 };
        public string HighPOP = "yes";
        public string Homeowner = "yes";

        static void Main(string[] args)
        {
            var _leadEntities = new ILeadEntity[5];

           
            //var something = new 
            Console.WriteLine("Enter the number lead you want to see: ");
            var lead = Console.ReadLine();
                
            if (lead == "1")
            {
                _leadEntities.ToString();
                Console.WriteLine("Processing Lead 1");
            }

            else if (lead == "2")
            {
                _leadEntities.ToString();
                Console.WriteLine("Processing Lead 2");
            }

            else if (lead == "3")
            {
                _leadEntities.ToString();
                Console.WriteLine("Processing Lead 3");
            }

            else if (lead == "4")
            {
                _leadEntities.ToString();
                Console.WriteLine("Processing Lead 4");
            }

            else if (lead == "5")
            {
                _leadEntities.ToString();
                Console.WriteLine("Processing Lead 5");
            }

            else
            {
                Console.WriteLine("Bad Lead......... Goodbye");
            }
            Console.ReadKey();

        }

        public bool isValid()
        {
            throw new NotImplementedException();
        }





        ILeadEntity[] CreateLeads(ILeadEntity[] _leadEntities)
        {


            _leadEntities[0] = new MyLeads
            {

                Context = new IContext[]
                {
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.ActivityGuidKey, Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.IdentityGuidKey, Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.SessionGuidKey,Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.QuotedProductKey,QuotedProduct.ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.AdditionalProductKey,AdditonalProducts)
                },

                Properties = new IProperty[]
                {
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.PriorBIKey,PriorBI),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.PriorInsuranceKey,PriorInsurance.ToString()),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.VehicleCountKey,VehicleCount.ToString()),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.QuotedBIKey,QuotedBI),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.DisplayedBrandsKey,DisplayedBrands.ToString())
                },

                Segments = new ISegment[]
                {
                    new MySegment(LeadEntity.Interface.Constants.SegementKeys.HighPOPKey),
                    new MySegment(LeadEntity.Interface.Constants.SegementKeys.HomeownerKey)
                }

            };

            _leadEntities[1] = new MyLeads
            {

                Context = new IContext[]
                {
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.ActivityGuidKey, Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.IdentityGuidKey, Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.SessionGuidKey,Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.QuotedProductKey,QuotedProduct.ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.AdditionalProductKey,AdditonalProducts)
                },

                Properties = new IProperty[]
                {
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.PriorBIKey,PriorBI),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.PriorInsuranceKey,PriorInsurance.ToString()),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.VehicleCountKey,VehicleCount.ToString()),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.QuotedBIKey,QuotedBI),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.DisplayedBrandsKey,DisplayedBrands.ToString())
                },

                Segments = new ISegment[]
                {
                    new MySegment(LeadEntity.Interface.Constants.SegementKeys.HighPOPKey),
                    new MySegment(LeadEntity.Interface.Constants.SegementKeys.HomeownerKey)
                }

            };

            _leadEntities[2] = new MyLeads
            {

                Context = new IContext[]
                {
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.ActivityGuidKey, Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.IdentityGuidKey, Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.SessionGuidKey,Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.QuotedProductKey,QuotedProduct.ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.AdditionalProductKey,AdditonalProducts)
                },

                Properties = new IProperty[]
                {
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.PriorBIKey,PriorBI),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.PriorInsuranceKey,PriorInsurance.ToString()),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.VehicleCountKey,VehicleCount.ToString()),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.QuotedBIKey,QuotedBI),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.DisplayedBrandsKey,DisplayedBrands.ToString())
                },

                Segments = new ISegment[]
                {
                    new MySegment(LeadEntity.Interface.Constants.SegementKeys.HighPOPKey),
                    new MySegment(LeadEntity.Interface.Constants.SegementKeys.HomeownerKey)
                }

            };

            _leadEntities[3] = new MyLeads
            {

                Context = new IContext[]
                {
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.ActivityGuidKey, Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.IdentityGuidKey, Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.SessionGuidKey,Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.QuotedProductKey,QuotedProduct.ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.AdditionalProductKey,AdditonalProducts)
                },

                Properties = new IProperty[]
                {
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.PriorBIKey,PriorBI),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.PriorInsuranceKey,PriorInsurance.ToString()),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.VehicleCountKey,VehicleCount.ToString()),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.QuotedBIKey,QuotedBI),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.DisplayedBrandsKey,DisplayedBrands.ToString())
                },

                Segments = new ISegment[]
                {
                    new MySegment(LeadEntity.Interface.Constants.SegementKeys.HighPOPKey),
                    new MySegment(LeadEntity.Interface.Constants.SegementKeys.HomeownerKey)
                }

            };

            _leadEntities[4] = new MyLeads
            {

                Context = new IContext[]
                {
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.ActivityGuidKey, Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.IdentityGuidKey, Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.SessionGuidKey,Guid.NewGuid().ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.QuotedProductKey,QuotedProduct.ToString()),
                    new MyContext(LeadEntity.Interface.Constants.ContextKeys.AdditionalProductKey,AdditonalProducts)
                },

                Properties = new IProperty[]
                {
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.PriorBIKey,PriorBI),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.PriorInsuranceKey,PriorInsurance.ToString()),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.VehicleCountKey,VehicleCount.ToString()),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.QuotedBIKey,QuotedBI),
                    new MyProperty(LeadEntity.Interface.Constants.PropertyKeys.DisplayedBrandsKey,DisplayedBrands.ToString())
                },

                Segments = new ISegment[]
                {
                    new MySegment(LeadEntity.Interface.Constants.SegementKeys.HighPOPKey),
                    new MySegment(LeadEntity.Interface.Constants.SegementKeys.HomeownerKey)
                }

            };
            return _leadEntities;
    }
    }


    class MyLeads : ILeadEntity
    {
        public IContext[] Context { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IProperty[] Properties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ISegment[] Segments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool isValid()
        {
            throw new NotImplementedException();
        }
    }

    struct MyContext : IContext
    {
        public MyContext(string id, object value)
        {
            Id = id;
            Value = value;
        }

        public string Id { get; private set; }

        public object Value { get; private set; }

        private string ToXmlString()
        {
            return string.Format("<Context id='{0}' value='{1}'/>", Id, Value);
        }

        private string ToJsonString()
        {
            return string.Format("{{\"Id\":\"{0}\", \"Value\":\"{1}\"}}", Id, Value);
        }

        public string ToString(FormatSpecifier format)
        {
            switch(format)
            {
                case FormatSpecifier.Xml:
                    return ToXmlString();

                case FormatSpecifier.Json:
                    return ToJsonString();

                default:
                    return string.Empty;
            }
        }

        public enum FormatSpecifier
        {
            Xml,
            Json
        }
    }

    struct MyProperty: IProperty
    {
        public MyProperty(string id, object value)
        {
            Id = id;
            Value = value;
        }
        public string Id { get; private set; }

        public object Value { get; private set; }       
    }

    struct MySegment : ISegment
    {
        public MySegment(string Type)
        {
            type = Type;
        }
        public string type { get; private set; }
    }

}
