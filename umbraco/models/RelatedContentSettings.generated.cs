//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Related Content Settings</summary>
	[PublishedModel("relatedContentSettings")]
	public partial class RelatedContentSettings : PublishedElementModel, IBackgroundColourElement, ISubtitleColourElement, ITextColourElement, ITitleColourElement, ITitleElement
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public new const string ModelTypeAlias = "relatedContentSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<RelatedContentSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public RelatedContentSettings(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Background Colour
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("backgroundColour")]
		public virtual string BackgroundColour => global::Umbraco.Cms.Web.Common.PublishedModels.BackgroundColourElement.GetBackgroundColour(this, _publishedValueFallback);

		///<summary>
		/// Subtitle Colour
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("subtitleTextColour")]
		public virtual string SubtitleTextColour => global::Umbraco.Cms.Web.Common.PublishedModels.SubtitleColourElement.GetSubtitleTextColour(this, _publishedValueFallback);

		///<summary>
		/// Text Content Colour
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("textContentColour")]
		public virtual string TextContentColour => global::Umbraco.Cms.Web.Common.PublishedModels.TextColourElement.GetTextContentColour(this, _publishedValueFallback);

		///<summary>
		/// Title Colour
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("titleColour")]
		public virtual string TitleColour => global::Umbraco.Cms.Web.Common.PublishedModels.TitleColourElement.GetTitleColour(this, _publishedValueFallback);

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("title")]
		public virtual string Title => global::Umbraco.Cms.Web.Common.PublishedModels.TitleElement.GetTitle(this, _publishedValueFallback);
	}
}
