using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Models;

namespace SPMeta2.Syntax.Default
{

    [Serializable]
    [DataContract]
    public class BlogAdminWebPartModelNode : WebPartModelNode
    {

    }

    public static class BlogAdminWebPartDefinitionSyntax
    {
        #region methods

        public static TModelNode AddBlogAdminWebPart<TModelNode>(this TModelNode model, BlogAdminWebPartDefinition definition)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return AddBlogAdminWebPart(model, definition, null);
        }

        public static TModelNode AddBlogAdminWebPart<TModelNode>(this TModelNode model, BlogAdminWebPartDefinition definition,
            Action<BlogAdminWebPartModelNode> action)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddBlogAdminWebParts<TModelNode>(this TModelNode model, IEnumerable<BlogAdminWebPartDefinition> definitions)
           where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion
    }
}
