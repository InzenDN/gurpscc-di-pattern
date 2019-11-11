using Autofac;
using GurpsCC.Model;
using GurpsCC.Model.Player;

namespace GurpsCC.ViewModel.Container
{
    public static class IoCContainer
    {
        public static IContainer Container { get; private set; }

        public static void Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<PlayerViewModel>().As<IPlayerViewModel>().SingleInstance();
            builder.RegisterType<BasePoints>().As<IBasePoints>().SingleInstance();
            builder.RegisterType<PlayerStat>().As<IPlayerStat>();

            builder.RegisterType<ActiveSkill>().As<IActiveSkill>();
            builder.RegisterType<ActiveAdvantage>().As<IActiveAdvantage>();
            builder.RegisterType<ActiveDisadvantage>().As<IActiveDisadvantage>();

            builder.RegisterType<GurpsMainDatabase>().As<IGurpsMainDatabase>().SingleInstance();
            builder.RegisterGeneric(typeof(GurpsDatabase<>)).As(typeof(IGurpsDatabase<>)).SingleInstance();

            builder.RegisterType<SelectedItem>().As<ISelectedItem>().SingleInstance();

            Container = builder.Build();
        }
    }
}
