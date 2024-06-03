using Cinemachine;
using UnityEngine;
using Zenject;

public class CameraInstaller : MonoInstaller
{
   [SerializeField] private CinemachineVirtualCamera _camera;

   public override void InstallBindings()
   {
      Container.BindInstance(_camera).AsSingle();
   }
}