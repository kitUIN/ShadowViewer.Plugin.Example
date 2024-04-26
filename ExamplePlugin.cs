using Serilog;
using ShadowViewer.Models;
using ShadowViewer.Plugins;
using ShadowViewer.Services;
using SqlSugar;
using System;

namespace ShadowViewer.Plugin.Example
{
    /// <summary>
    /// �������
    /// </summary>
    [AutoPluginMeta]
    public partial class ExamplePlugin : PluginBase
    {
        /// <summary>
        /// �Զ�����ע��
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
            Logger.Information("[{ID}]����PluginEnabled", MetaData.Id);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        protected override void PluginDisabled()
        {
            Logger.Information("[{ID}]����PluginDisabled", MetaData.Id);
        }
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void PluginDeleting()
        {
            Logger.Information("[{ID}]����PluginDeleting", MetaData.Id);
        }
    }
}
