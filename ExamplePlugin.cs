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
    /// �������
    /// </summary>
    [AutoPluginMeta]
    public partial class ExamplePlugin : PluginBase
    {
        /// <summary>
        /// �Զ�����ע��
        /// </summary>
        public ExamplePlugin(ICallableService callableService, 
            ISqlSugarClient sqlSugarClient, 
            CompressService compressServices, 
            PluginLoader pluginService, 
            ILogger logger) : base(
            callableService, sqlSugarClient, 
            compressServices, pluginService, logger)
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
        public override string DisplayName => "ʾ�����";
    }
}
