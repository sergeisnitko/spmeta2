using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Models;

namespace SPMeta2.Syntax.Default
{

    [Serializable]
    [DataContract]
    public class BlogMonthQuickLaunchModelNode : WebPartModelNode
    {

    }

    public static class BlogMonthQuickLaunchDefinitionSyntax
    {
        #region methods

        public static TModelNode AddBlogMonthQuickLaunch<TModelNode>(this TModelNode model, BlogMonthQuickLaunchDefinition definition)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return AddBlogMonthQuickLaunch(model, definition, null);
        }

        public static TModelNode AddBlogMonthQuickLaunch<TModelNode>(this TModelNode model, BlogMonthQuickLaunchDefinition definition,
            Action<BlogMonthQuickLaunchModelNode> action)
            where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddBlogMonthQuickLaunchs<TModelNode>(this TModelNode model, IEnumerable<BlogMonthQuickLaunchDefinition> definitions)
           where TModelNode : ModelNode, IWebpartHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion
    }
}
