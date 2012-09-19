using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Api.Facebook
{
  public  class Currency
    {
      /// <summary>
      /// usercurrency content string
      /// </summary>
      [DataMember(Name = "user_currency")]
      public string UserCurrency { get; set;}
      /// <summary>
      /// currencyexchange content integer
      /// </summary>
      [DataMember(Name = "currency_exchange")]
      public int CurrencyExchange { get; set;}
      /// <summary>
      /// currencyexchangeinverse content float
      /// </summary>
      [DataMember(Name = "currency_exchange_inverse")]
      public float CurrencyExchangeInverse { get; set;}
      /// <summary>
      /// currencyoffset content integer
      /// </summary>
      [DataMember(Name = "currency_offset")]
      public int CurrencyOffSet { get; set; }
    }
}
