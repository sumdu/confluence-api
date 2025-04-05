using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RichkaSoft.Confluence.ApiV2.ApiAreas.Models.Pages;

public enum GetPagesByLabelRequestBodyFormatEnum
{
    [EnumMember(Value = "storage")]
    Storage,
    [EnumMember(Value = "atlas_doc_format")]
    AtlasDocFormat,
}
