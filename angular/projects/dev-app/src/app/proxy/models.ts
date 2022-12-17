import type { IRemoteStreamContent } from './volo/abp/content/models';

export interface UploadDto {
  text?: string;
  timestamp: number;
  singleFile: IRemoteStreamContent;
  files: IRemoteStreamContent[];
}
