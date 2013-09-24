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
  public  class CouponVerificationInfo
    {
        [DataMember]
        private System.Nullable<bool> _verification;

        [DataMember]
        private System.Nullable<int> _couponID;
        [DataMember]
		private System.Nullable<decimal> _couponAmount;
        [DataMember]
        private System.Nullable<bool> _isPercentage;
        [DataMember]
		private string _isForFreeShipping;

        public CouponVerificationInfo()
		{
		}
		
		public System.Nullable<bool> Verification
		{
			get
			{
				return this._verification;
			}
			set
			{
				if ((this._verification != value))
				{
					this._verification = value;
				}
			}
		}

        public System.Nullable<int> CouponID
        {
            get
            {
                return this._couponID;
            }
            set
            {
                if ((this._couponID != value))
                {
                     this._couponID=value;
                }
            }
        }
		public System.Nullable<decimal> CouponAmount
		{
			get
			{
				return this._couponAmount;
			}
			set
			{
				if ((this._couponAmount != value))
				{
					this._couponAmount = value;
				}
			}
		}

        public System.Nullable<bool> IsPercentage
        {
            get
            {
                return this._isPercentage;
            }
            set
            {
                if ((this._isPercentage != value))
                {
                    this._isPercentage = value;
                }
            }
        }
		
		public string IsForFreeShipping
		{
			get
			{
				return this._isForFreeShipping;
			}
			set
			{
				if ((this._isForFreeShipping != value))
				{
					this._isForFreeShipping = value;
				}
			}
		}
    }

}
