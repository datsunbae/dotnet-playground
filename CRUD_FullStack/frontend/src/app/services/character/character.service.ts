import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Character } from 'src/app/models/character.model';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root',
})
export class CharacterService {
  apiURL: string = environment.apiUrl;
  constructor(private httpClient: HttpClient) {}

  getAllCharacters(): Observable<Character[]> {
    return this.httpClient.get<Character[]>(this.apiURL + '/api/characters');
  }

  getCharacter(id: string): Observable<Character> {
    return this.httpClient.get<Character>(
      this.apiURL + '/api/characters/' + id
    );
  }

  addCharacter(character: Character): Observable<Character> {
    return this.httpClient.post<Character>(
      this.apiURL + '/api/characters/',
      character
    );
  }

  updateChracter(id: string, character: Character): Observable<Character> {
    return this.httpClient.put<Character>(
      this.apiURL + '/api/characters/' + id,
      character
    );
  }

  deleteCharacter(id: string): Observable<Character> {
    return this.httpClient.delete<Character>(
      this.apiURL + '/api/characters/' + id
    );
  }
}
