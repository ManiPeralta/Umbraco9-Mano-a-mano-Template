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
	/// <summary>News Item</summary>
	[PublishedModel("newsItem")]
	public partial class NewsItem : PublishedContentModel, IRelatedNewsContent, ISEoelement, ISummaryElement, ITitleElement
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public new const string ModelTypeAlias = "newsItem";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<NewsItem, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public NewsItem(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Author
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("author")]
		public virtual string Author => this.Value<string>(_publishedValueFallback, "author");

		///<summary>
		/// Categories
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("categories")]
		public virtual global::System.Collections.Generic.IEnumerable<string> Categories => this.Value<global::System.Collections.Generic.IEnumerable<string>>(_publishedValueFallback, "categories");

		///<summary>
		/// Main Picture
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("mainPicture")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops MainPicture => this.Value<global::Umbraco.Core.Models.MediaWithCrops>(_publishedValueFallback, "mainPicture");

		///<summary>
		/// Published Dated
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("publishedDated")]
		public virtual global::System.DateTime PublishedDated => this.Value<global::System.DateTime>(_publishedValueFallback, "publishedDated");

		///<summary>
		/// Slogan
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("slogan")]
		public virtual string Slogan => this.Value<string>(_publishedValueFallback, "slogan");

		///<summary>
		/// Text Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("textContent")]
		public virtual global::Newtonsoft.Json.Linq.JToken TextContent => this.Value<global::Newtonsoft.Json.Linq.JToken>(_publishedValueFallback, "textContent");

		///<summary>
		/// Related News Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("relatedNewsItems")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel RelatedNewsItems => global::Umbraco.Cms.Web.Common.PublishedModels.RelatedNewsContent.GetRelatedNewsItems(this, _publishedValueFallback);

		///<summary>
		/// SEO Description: Between 155–160 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("sEODescription")]
		public virtual string SEodescription => global::Umbraco.Cms.Web.Common.PublishedModels.SEoelement.GetSEodescription(this, _publishedValueFallback);

		///<summary>
		/// SEO Title: Keep your titles under 60 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("sEOTitle")]
		public virtual string SEotitle => global::Umbraco.Cms.Web.Common.PublishedModels.SEoelement.GetSEotitle(this, _publishedValueFallback);

		///<summary>
		/// Summary
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("summary")]
		public virtual string Summary => global::Umbraco.Cms.Web.Common.PublishedModels.SummaryElement.GetSummary(this, _publishedValueFallback);

		///<summary>
		/// Thumbnail
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("thumbnail")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops Thumbnail => global::Umbraco.Cms.Web.Common.PublishedModels.SummaryElement.GetThumbnail(this, _publishedValueFallback);

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("title")]
		public virtual string Title => global::Umbraco.Cms.Web.Common.PublishedModels.TitleElement.GetTitle(this, _publishedValueFallback);
	}
}
