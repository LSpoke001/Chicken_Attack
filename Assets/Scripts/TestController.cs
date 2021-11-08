using ChickenAttack;
using ChickenAttack.Controller;
using UnityEngine;
using Zenject;

public class TestController : MonoInstaller
{
    [SerializeField] private MainController controller;
    public override void InstallBindings()
    {
        Container.Bind<MainController>().FromInstance(controller).AsSingle().NonLazy();
    }
}