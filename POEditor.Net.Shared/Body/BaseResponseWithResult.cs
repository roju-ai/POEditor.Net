using Newtonsoft.Json;
using POEditor.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace POEditor.Body
{
    public class BaseResponseWithResult<T> : BaseResponse
    {
        [JsonProperty("result")]
        public T Result { get; set; }
    }
}
