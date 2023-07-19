import { Component } from '@angular/core';
import { Character, Gender } from 'src/app/models/character.model';

@Component({
  selector: 'app-character-edit',
  templateUrl: './character-edit.component.html',
  styleUrls: ['./character-edit.component.css'],
})
export class CharacterEditComponent {
  genders: Gender[] = Object.values(Gender);
  character: Character = {
    id: '00000000-0000-0000-0000-000000000000',
    name: '',
    gender: Gender.Male,
    birthday: '',
    height: 0,
    weight: 0,
    image: '',
  };
  constructor() {}
  ngOninit() {}
  onSubmit() {}
}
