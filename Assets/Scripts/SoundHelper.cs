﻿using UnityEngine;
using System.Collections;

public class SoundHelper : MonoBehaviour {

  /// <summary>
  /// Singleton
  /// </summary>
  public static SoundHelper Instance;

  public AudioClip penguinHitSound;

  void Awake()
  {
    // Register the singleton
    if (Instance != null)
    {
        Debug.LogError("Multiple instances of SoundHelper!");
    }
    Instance = this;
  }


  public void MakePenguinHitSound()
  {
      MakeSound(penguinHitSound);
  }



  /// <summary>
  /// Play a given sound
  /// </summary>
  /// <param name="originalClip"></param>
  private void MakeSound(AudioClip originalClip)
  {
    // As it is not 3D audio clip, position doesn't matter.
    AudioSource.PlayClipAtPoint(originalClip, transform.position);
  }
}
