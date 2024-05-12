using Gameplay;
using UnityEngine;
using Zenject;

namespace Global
{
	public class GlobalInstaller : MonoInstaller
	{
		[SerializeField] private DesktopInput _desktopInput;

		public override void InstallBindings()
		{
			Container.Bind<IInput>().To<DesktopInput>().FromInstance(_desktopInput).AsSingle();
		}
	}
}
