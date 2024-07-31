using Serilog;
using ShadowViewer.Models;
using ShadowViewer.Plugins;
using ShadowViewer.Services;
using SqlSugar;
using System;
using ShadowPluginLoader.MetaAttributes;

namespace ShadowViewer.Plugin.Example
{
    /// <summary>
    /// 插件主类
    /// </summary>
    [AutoPluginMeta]
    public partial class ExamplePlugin : AShadowViewerPlugin
    {
        /// <summary>
        /// 自动依赖注入
        /// </summary>
        public ExamplePlugin(ICallableService caller, ISqlSugarClient db, CompressService compressService, ILogger logger, PluginLoader pluginService, INotifyService notifyService) :
            base(caller, db, compressService, logger, pluginService, notifyService)
        {
        }

        /// <inheritdoc />
        public override PluginMetaData MetaData => Meta;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override LocalTag AffiliationTag { get; } = new LocalTag("Example", "#000000", "#ffd657");

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override Type? SettingsPage => null;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override bool CanSwitch => true;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override bool CanDelete => true;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override bool CanOpenFolder => true;

        /// <inheritdoc />
        public override string DisplayName => "示例插件";
    }
}
