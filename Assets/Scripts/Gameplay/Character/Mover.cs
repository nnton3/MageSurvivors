using System;
using UnityEngine;
using Zenject;

namespace Gameplay.Character
{
	public class Mover : MonoBehaviour, IDisposable
	{
		[SerializeField] private float _speed = 100f;
		[SerializeField] private Rigidbody2D rb;
		private IInput _input;
		private Vector2 _direction;

		[Inject]
		public void Construct(IInput input)
		{
			_input = input;
			_input.OnDirectionChanged += DirectionChangedHandler;
		}

		private void DirectionChangedHandler(Vector2 direction) => _direction = direction;

		public void FixedUpdate()
		{
			rb.velocity = _direction * _speed * Time.deltaTime;
		}

		public void Dispose()
		{
			_input.OnDirectionChanged -= DirectionChangedHandler;
		}
	}
}
