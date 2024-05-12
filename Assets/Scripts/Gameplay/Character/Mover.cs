using System;

namespace Gameplay.Character
{
	public class Mover : IDisposable
	{
		public Mover(IInput input)
		{
			input.MoveForward += MoveForwardHandler;
			input.MoveBackward += MoveBackwardHandler;
			input.MoveLeft += MoveLeftHandler;
			input.MoveRight += MoveRightHandler;
		}

		private void MoveForwardHandler() { }
		private void MoveBackwardHandler() { }
		private void MoveLeftHandler() { }
		private void MoveRightHandler() { }

		public void Dispose()
		{
			
		}
	}
}
