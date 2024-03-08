import {createPublicizer} from "publicizer";

export const publicizer = createPublicizer("Neon");

publicizer.createAssembly("tModLoader").publicizeAll();
