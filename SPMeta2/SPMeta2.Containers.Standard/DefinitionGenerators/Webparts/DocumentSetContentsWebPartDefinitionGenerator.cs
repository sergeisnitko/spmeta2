using System;
using SPMeta2.Containers.Services.Base;
using SPMeta2.Definitions;
using SPMeta2.Standard.Definitions.Webparts;
using SPMeta2.Enumerations;
using System.Collections.Generic;
using SPMeta2.Syntax.Default;

namespace SPMeta2.Containers.Standard.DefinitionGenerators.Webparts
{
    public class DocumentSetContentsWebPartDefinitionGenerator : TypedDefinitionGeneratorServiceBase<DocumentSetContentsWebPartDefinition>
    {
        public override DefinitionBase GenerateRandomDefinition(Action<DefinitionBase> action)
        {
            return WithEmptyDefinition(def =>
            {
                def.Id = Rnd.String();
                def.Title = Rnd.String();

                def.ZoneId = "FullPage";
                def.ZoneIndex = Rnd.Int(100);

                // TODO
            });
        }

        public override IEnumerable<DefinitionBase> GetAdditionalArtifacts()
        {
            var documentSetsFeature = BuiltInSiteFeatures.DocumentSets.Inherit(f =>
            {
                f.Enable = true;
            });

            return new DefinitionBase[] { documentSetsFeature };
        }
    }
}
