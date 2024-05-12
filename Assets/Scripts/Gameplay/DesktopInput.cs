using System;

namespace Gameplay
{
	public class DesktopInput : IInput
	{
		public event Action MoveForward;
		public event Action MoveBackward;
		public event Action MoveLeft;
		public event Action MoveRight;
	}
}
