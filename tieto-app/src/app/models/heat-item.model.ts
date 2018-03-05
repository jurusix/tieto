import { Base } from './base.model';

export interface HeatItem extends Base  {
  temperatures: Array<number>;
}
