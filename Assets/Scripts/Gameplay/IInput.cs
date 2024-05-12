using System;
using UnityEngine;

namespace Gameplay
{
	public interface IInput
	{
		event Action<Vector2> OnDirectionChanged;
	}
}
