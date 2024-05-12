using UnityEngine;
using Zenject;

namespace Gameplay.Character
{
	public class Player : MonoBehaviour
	{
		private Mover _mover;

		[Inject]
		public void Construct(Mover mover)
		{
			_mover = mover;
		}
	}
}
