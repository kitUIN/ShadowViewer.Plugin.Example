using Serilog;
using ShadowViewer.Models;
using ShadowViewer.Plugins;
using ShadowViewer.Services;
using SqlSugar;
using System;

namespace ShadowViewer.Plugin.Example
{
    /// <summary>
    /// 插件主类
    /// </summary>
    [AutoPluginMeta]
    public partial class ExamplePlugin : PluginBase
    {
        /// <summary>
        /// 自动依赖注入
        /// </summary>
        public ExamplePlugin(ICallableService callableService, ISqlSugarClient sqlSugarClient, CompressService compressServices, IPluginService pluginService, ILogger logger) : base(callableService, sqlSugarClient, compressServices, pluginService, logger)
        {
        }

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

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        protected override void PluginEnabled()
        {
            Logger.Information("[{ID}]触发PluginEnabled", MetaData.Id);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        protected override void PluginDisabled()
        {
            Logger.Information("[{ID}]触发PluginDisabled", MetaData.Id);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void PluginDeleting()
        {
            Logger.Information("[{ID}]触发PluginDeleting", MetaData.Id);
        }
    }
}
