using System.Collections.Generic;
using CrudRepository.Core;
using CrudRepository.Implementations;
using UnityEngine;

namespace CrudRepository.Installers
{
        public class SpriteDictionaryCrudRepositoryInstaller : DictionaryCrudRepositoryInstaller<int, Sprite>
        {
            [SerializeField] private List<Sprite> _sprites;
        
            protected override ICrudRepository<int, Sprite> GetData()
            {
                DictionaryCrudRepository<int, Sprite> dictionaryCrudRepository = new DictionaryCrudRepository<int, Sprite>();

                for (int i = 0; i < _sprites.Count; i++)
                {
                    dictionaryCrudRepository.Insert(i, _sprites[i]);
                }

                return dictionaryCrudRepository;
            }
        }
}