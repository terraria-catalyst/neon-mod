import {createPublicizer} from "publicizer";

export const publicizer = createPublicizer("Graphite");

publicizer.createAssembly("tModLoader").publicizeAll();
