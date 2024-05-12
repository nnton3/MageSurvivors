using Gameplay.Character;
using Zenject;

public class GameplayInstaller : MonoInstaller
{
	public override void InstallBindings()
	{
		Container.Bind<Mover>().AsSingle();
	}
}