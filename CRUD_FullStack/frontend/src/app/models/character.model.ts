export enum Gender {
  Male,
  Female,
  Other,
}

export interface Character {
  id: string;
  name: string;
  gender: Gender;
  birthday: string;
  height: number;
  weight: number;
  image: string;
}
