using System;

namespace Gameplay
{
	public interface IInput
	{
		event Action MoveForward;
		event Action MoveBackward;
		event Action MoveLeft;
		event Action MoveRight;
	}
}
