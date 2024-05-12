using UnityEngine;
using Zenject;

namespace Gameplay.Character
{
	public class Player : MonoBehaviour
	{
		[SerializeField] private Animator _anim;

		[Inject]
		public void Construct() { }

		public void PlayAnim()
		{
			_anim.SetTrigger("");
		}
	}
}
