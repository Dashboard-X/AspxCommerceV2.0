﻿/*
AspxCommerce® - http://www.aspxcommerce.com
Copyright (c) 20011-2012 by AspxCommerce
Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System;
using System.Runtime.Serialization;

namespace AspxCommerce.Core
{
    [DataContract]
    [Serializable]
    public class ShippingCostDependencyInfo
    {
         [DataMember(Name = "_rowTotal", Order = 0)]
        private System.Nullable<int> _rowTotal;

        [DataMember(Name = "_shippingProductCostID", Order = 1)]
		private int _shippingProductCostID;

        [DataMember(Name = "_shippingMethodID", Order = 2)]
        private int _shippingMethodID;

        [DataMember(Name = "_cost", Order = 3)]
        private string _cost;

        [DataMember(Name = "_rateValue", Order = 4)]
		private System.Nullable<decimal> _rateValue;

        [DataMember(Name = "_isRateInPercentage", Order = 5)]
        private string _isRateInPercentage;

        //[DataMember(Name = "_IsWeightInPercentage", Order = 5)]
        //private string _IsWeightInPercentage;

        [DataMember(Name = "_addedOn", Order = 6)]
		private System.Nullable<System.DateTime> _addedOn;

        [DataMember(Name = "_addedBy", Order = 7)]
		private string _addedBy;





        public ShippingCostDependencyInfo()
		{
		}
		
		
		public System.Nullable<int> RowTotal
		{
			get
			{
				return this._rowTotal;
			}
			set
			{
				if ((this._rowTotal != value))
				{
					this._rowTotal = value;
				}
			}
		}
		
	
		public int ShippingProductCostID
		{
			get
			{
				return this._shippingProductCostID;
			}
			set
			{
				if ((this._shippingProductCostID != value))
				{
					this._shippingProductCostID = value;
				}
			}
		}

        public int ShippingMethodID
        {
            get
            {
                return this._shippingMethodID;
            }
            set
            {
                if ((this._shippingMethodID != value))
                {
                    this._shippingMethodID = value;
                }
            }
        }
		
		public string Cost
		{
			get
			{
				return this._cost;
			}
			set
			{
				if ((this._cost != value))
				{
					this._cost = value;
				}
			}
		}
		

		public System.Nullable<decimal> RateValue
		{
			get
			{
				return this._rateValue;
			}
			set
			{
				if ((this._rateValue != value))
				{
					this._rateValue = value;
				}
			}
		}

        public string IsRateInPercentage
        {
            get
            {
                return this._isRateInPercentage;
            }
            set
            {
                if ((this._isRateInPercentage != value))
                {
                    this._isRateInPercentage = value;
                }
            }
        }

        //public  string IsWeightInPercentage
        //{
        //    get
        //    {
        //        return this._IsWeightInPercentage;
        //    }
        //    set
        //    {
        //        if ((this._IsWeightInPercentage != value))
        //        {
        //            this._IsWeightInPercentage = value;
        //        }
        //    }
        //}
	
		public System.Nullable<System.DateTime> AddedOn
		{
			get
			{
				return this._addedOn;
			}
			set
			{
				if ((this._addedOn != value))
				{
					this._addedOn = value;
				}
			}
		}
	
		public string AddedBy
		{
			get
			{
				return this._addedBy;
			}
			set
			{
				if ((this._addedBy != value))
				{
					this._addedBy = value;
				}
			}
		}
		
		
		
    }
}
