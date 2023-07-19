import { Component } from '@angular/core';
import { Character, Gender } from 'src/app/models/character.model';
import { CharacterService } from 'src/app/services/character/character.service';

@Component({
  selector: 'app-character-add',
  templateUrl: './character-add.component.html',
  styleUrls: ['./character-add.component.css'],
})
export class CharacterAddComponent {
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

  constructor(private characterServices: CharacterService) {}
  ngOnInit() {}

  onSubmit() {
    // this.characterServices
    //   .addCharacter(this.character)
    //   .subscribe((character) => {
    //     console.log(character);
    //   });
    console.log(this.character);
  }
}
