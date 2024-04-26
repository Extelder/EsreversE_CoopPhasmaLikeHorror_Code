using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RoomSpawner : MonoBehaviour
{
    [SerializeField] private ClampRoom _defaultRoom;
    [SerializeField] private ClampRoom[] _roomVariants;
    [SerializeField] private int _minRooms = 5;
    [SerializeField] private int _maxRooms = 10;

    private List<ClampRoom> _spawnedRooms = new List<ClampRoom>();

    private void Start()
    {
        StartCoroutine(Spawning());
    }

    private IEnumerator Spawning()
    {
        int numberOfRooms = Random.Range(_minRooms, _maxRooms);
        while (_spawnedRooms.Count < numberOfRooms)
        {
            yield return new WaitForSeconds(0.1f);

            if (_spawnedRooms.Count == 0)
            {
                _spawnedRooms.Add(Instantiate(_roomVariants[Random.Range(0, _roomVariants.Length)],
                    _defaultRoom.NextSpawnPlace.position,
                    Quaternion.identity).GetComponent<ClampRoom>());
            }
            
            _spawnedRooms.Add(Instantiate(_roomVariants[Random.Range(0, _roomVariants.Length)],
                _spawnedRooms[_spawnedRooms.Count - 1].NextSpawnPlace.position,
                Quaternion.identity).GetComponent<ClampRoom>());
        }
    }
}