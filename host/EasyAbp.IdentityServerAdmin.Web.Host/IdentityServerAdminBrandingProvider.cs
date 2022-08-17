using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace EasyAbp.IdentityServerAdmin
{
    [Dependency(ReplaceServices = true)]
    public class IdentityServerAdminBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "IdentityServerAdmin";
    }
}
