﻿using System;

using Newtonsoft.Json;

namespace commercetools.Products
{
    /// <summary>
    /// SearchKeyword
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#searchkeyword"/>
    public class SearchKeyword
    {
        #region Properties

        [JsonProperty(PropertyName = "text")]
        public string Text { get; private set; }

        [JsonProperty(PropertyName = "suggestTokenizer")]
        public SuggestTokenizer SuggestTokenizer { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes this instance with JSON data from an API response.
        /// </summary>
        /// <param name="data">JSON object</param>
        public SearchKeyword(dynamic data = null)
        {
            if (data == null)
            {
                return;
            }

            this.Text = data.text;
            this.SuggestTokenizer = SuggestTokenizerFactory.Create(data.suggestTokenizer);
        }

        #endregion
    }
}