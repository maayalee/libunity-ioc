﻿using UnityEngine;
using libunity.ioc;

public class Bootstrapper : MonoBehaviour {
  private void Awake() {
    var container = new dependency_container();
    Dependency_Extensions.set_container(container);
    configure(container);
  }

  private void configure(ioc_container_base container) {
    container.register(new GameObject("/logger").AddComponent<Logger>());
    container.register(GameObject.FindObjectOfType<Camera>());
  }
}