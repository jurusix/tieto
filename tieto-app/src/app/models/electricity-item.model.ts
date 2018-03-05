import { Base } from './base.model';

enum BuildingType {
  Other = 0,
  Flat = 1,
  House = 2
}

export interface ElectricityItem extends Base  {
  type: BuildingType;
}
