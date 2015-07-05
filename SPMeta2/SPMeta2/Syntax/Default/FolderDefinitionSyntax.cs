﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPMeta2.Definitions;
using SPMeta2.Models;
using SPMeta2.Syntax.Default.Extensions;

namespace SPMeta2.Syntax.Default
{
    public class FolderModelNode : TypedModelNode,
        ISecurableObjectHostModelNode,
        IListItemHostModelNode,
        IFolderHostModelNode,
        IWelcomePageHostModelNode,
        IModuleFileHostModelNode
    {

    }

    public static class FolderDefinitionSyntax
    {
        #region add folders

        #region methods

        public static TModelNode AddFolder<TModelNode>(this TModelNode model, FolderDefinition definition)
            where TModelNode : ModelNode, IFolderHostModelNode, new()
        {
            return AddFolder(model, definition, null);
        }

        public static TModelNode AddFolder<TModelNode>(this TModelNode model, FolderDefinition definition,
            Action<FolderModelNode> action)
            where TModelNode : ModelNode, IFolderHostModelNode, new()
        {
            return model.AddTypedDefinitionNode(definition, action);
        }

        #endregion

        #region array overload

        public static TModelNode AddFolders<TModelNode>(this TModelNode model, IEnumerable<FolderDefinition> definitions)
           where TModelNode : ModelNode, IFolderHostModelNode, new()
        {
            foreach (var definition in definitions)
                model.AddDefinitionNode(definition);

            return model;
        }

        #endregion

        #endregion

        #region array overload
        //public static ModelNode AddFolders(this ModelNode model, IEnumerable<FolderDefinition> definitions)
        //{
        //    foreach (var definition in definitions)
        //        model.AddDefinitionNode(definition);

        //    return model;
        //}

        #endregion

        #region add host

        //public static ModelNode AddHostFolder(this ModelNode model, FolderDefinition definition)
        //{
        //    return AddHostFolder(model, definition, null);
        //}

        //public static ModelNode AddHostFolder(this ModelNode model, FolderDefinition definition, Action<ModelNode> action)
        //{
        //    return model.AddDefinitionNodeWithOptions(definition, action, ModelNodeOptions.New().NoSelfProcessing());
        //}

        #endregion
    }
}