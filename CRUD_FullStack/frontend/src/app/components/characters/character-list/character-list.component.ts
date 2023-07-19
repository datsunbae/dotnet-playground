import { Component } from '@angular/core';
import { Character, Gender } from 'src/app/models/character.model';

@Component({
  selector: 'app-character-list',
  templateUrl: './character-list.component.html',
  styleUrls: ['./character-list.component.css'],
})
export class CharacterListComponent {
  characters: Character[] = [
    {
      id: '2bb5c474-a5f5-491f-9afd-631487ee965d',
      name: 'Tanjiro Kamado',
      gender: Gender.Male,
      birthday: '14/07',
      height: 165,
      weight: 61,
      image:
        'https://f.fcdn.app/imgs/9b1acc/www.xuruguay.com.uy/xuruuy/005b/original/catalogo/8896984901088896984901083/460x460/tanjiro-kamado-demon-slayer-867-tanjiro-kamado-demon-slayer-867.jpg',
    },
    {
      id: '8570e82f-33b3-495c-8875-b55d943cfbd8',
      name: 'Mitsuri Kanroji',
      gender: Gender.Female,
      birthday: '01/06',
      height: 167,
      weight: 56,
      image:
        'https://lumeye.com/cdn/shop/products/Mitsuri-Kanroji.jpg?v=1663739985',
    },
    {
      id: '3526edb6-9c41-4241-b716-05c459632a18',
      name: 'Nezuko Kamado',
      gender: Gender.Female,
      birthday: '28/12',
      height: 153,
      weight: 45,
      image:
        'https://thicc.mywaifulist.moe/waifus/18952/02937b2553cbd8d6975618a564fc97dcf34d57e5b164a13c3d597cbd3bdcce2d_thumb.jpg',
    },
  ];
  itemIdToDelete: string = '';
  constructor() {}
  ngOnInit() {}
  openDeleteConfirmModel(id: string) {
    this.itemIdToDelete = id;
    $('#deleteConfirmationModal').modal('show');
  }

  deleteItem(itemId: string) {
    alert(itemId);
    $('#deleteConfirmationModal').modal('hide');
  }
}
