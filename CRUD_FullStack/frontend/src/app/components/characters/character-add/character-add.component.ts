import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Character, Gender } from 'src/app/models/character.model';
import { CharacterService } from 'src/app/services/character/character.service';

@Component({
  selector: 'app-character-add',
  templateUrl: './character-add.component.html',
  styleUrls: ['./character-add.component.css'],
})
export class CharacterAddComponent {
  genderOptions = [
    { lable: 'Male', value: Gender.Male },
    { lable: 'Female', value: Gender.Female },
    { lable: 'Other', value: Gender.Other },
  ];
  character: Character = {
    id: '00000000-0000-0000-0000-000000000000',
    name: '',
    gender: Gender.Male,
    birthday: '',
    height: 0,
    weight: 0,
    image: '',
  };

  constructor(
    private characterServices: CharacterService,
    private router: Router
  ) {}
  ngOnInit() {}

  onSubmit() {
    this.character.gender = parseInt(this.character.gender.toString());

    this.characterServices.addCharacter(this.character).subscribe({
      next: (character) => {
        this.router.navigate(['characters']);
      },
      error: (error) => {
        alert(error.message);
      },
    });
  }
}
