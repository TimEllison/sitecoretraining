using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace TrainingDemo.Models
{

    /// <summary>
    /// Decorate the model class  with SitecoreType(TemplateId="string representation of GUID"
    /// Ideally, the template id is stored in Constants to improve human readability
    /// </summary>
    [SitecoreType(TemplateId = TemplateConstants.Hero)]
    public class HeroModel
    {

        /// <summary>
        /// Bare minimum for supporting editability in Experience Editor.  Include the Sitecore ID
        /// Fields are declared virtual because these classes are proxied.
        /// </summary>
        [SitecoreId]
        public virtual Guid ID { get; set; }


        /// <summary>
        /// Notice special field type support by Glass Mapper.  
        /// Without this field type, you would have to use the Media Manager to get to the underlying item attributes.
        /// </summary>
        [SitecoreField("Logo")]
        public virtual Image Logo { get; set; }
    }
}
