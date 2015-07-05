﻿using SPMeta2.Definitions;
using SPMeta2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPMeta2.Syntax.Default.Extensions;

namespace SPMeta2.Syntax.Default
{

    public class ListItemModelNode : TypedModelNode, IListItemModelNode,
        ISecurableObjectHostModelNode
    {

    }

    public static class ListItemDefinitionSyntax
    {
        #region methods

        public static TModelNode AddListItem<TModelNode>(this TModelNode model, ListItemDefinition definition)
            where TModelNode : ModelNode, IListItemHostModelNode, new()
        {
            return AddListItem(model, definition, null);
        }

        public static TModelNode AddListItem<TModelNode>(this TModelNode model, ListItemDefinition definition,
            Action<ListItemModelNode> action)
            where TModelNode : ModelNode, IListItemHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddListItems<TModelNode>(this TModelNode model, IEnumerable<ListItemDefinition> definitions)
           where TModelNode : ModelNode, IListItemHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion


        #region add host

        //public static ModelNode AddHostListItem(this ModelNode model, ListItemDefinition definition)
        //{
        //    return AddHostListItem(model, definition, null);
        //}

        //public static ModelNode AddHostListItem(this ModelNode model, ListItemDefinition definition, Action<ModelNode> action)
        //{
        //    return model.AddDefinitionNodeWithOptions(definition, action, ModelNodeOptions.New().NoSelfProcessing());
        //}

        #endregion
    }
}