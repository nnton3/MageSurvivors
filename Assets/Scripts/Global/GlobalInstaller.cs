using Gameplay;
using Zenject;

namespace Global
{
	public class GlobalInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.Bind<IInput>().To<DesktopInput>().AsSingle();
		}
	}
}
